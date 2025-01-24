using Newtonsoft.Json;
using System;
using System.Data;
using System.Dynamic;

namespace login
{
    public object UserAuthentication(object inputData)
    {
        LoginUser objRequest = null;
        try
        {
            objRequest = JsonConvert.DeserializeObject<LoginUser>(inputData.ToString());
        }
        catch { }

        if (objRequest == null)
        {
            return new Response
            {
                ResCode = "1",
                ResDesc = "Invalid request"
            };
        }

        long lTimeTaken = -1, lStart = DateTime.Now.Ticks;
        DataSet ds = new DataSet();
        DataTable dtUser = new DataTable();
        DataTable dtUserMeta = new DataTable();
        dynamic objResponse = new ExpandoObject();
        string strPassword = string.Empty;
        String strMD5Hash = string.Empty;
        try
        {
            //strPassword = new RC4(objRequest.Pwd).Decrypt();
            //strMD5Hash = new RC4(strPassword).Encrypt();//General.GetMD5Hash(strPassword);
            object retVal = -1;
            using (DBFactory objDB = new DBFactory(DSN_CONN))
            {
                objDB.AddInParam("Mobileno", SqlType.VarChar, objRequest.MobileNo);
                objDB.AddInParam("Pwd", SqlType.VarChar, strMD5Hash);
                objDB.AddInParam("TYPE", SqlType.VarChar, "L");
                objDB.AddOutParam("RETSTATUS", SqlType.VarChar, 10);
                objDB.RunProc("USERLIST_CRUD", out ds, 2);
                retVal = objDB.GetOutValue("RETSTATUS");
            }
            if (retVal.ToStr() == "0")
            {
                // log IMEI code
                long resCode = 0;
                long IMEICode = !string.IsNullOrWhiteSpace(objRequest.IMEI) ? objRequest.IMEI.ToLong() : 0;
                if (IMEICode != 0 && IMEICode.ToString().Length == 15)
                {
                    try
                    {
                        using (DBFactory objDB = new DBFactory("DSN_USER"))
                        {
                            objDB.AddInParam("MOBILENO", SqlType.Decimal, objRequest.MobileNo);
                            objDB.AddInParam("IMEI", SqlType.Decimal, objRequest.IMEI);
                            objDB.AddOutParam("RESCODE", SqlType.Int, 8);
                            objDB.RunProc("UDP_INS_MSISDN_VS_IMIEICODE");
                            long.TryParse(objDB.GetOutValue("RESCODE").ToStr(), out resCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogData.Write("MESEVA", "PAYMENT_DB", LogMode.Excep, ex, string.Format("Common => insertUserIMEICode- Ex:{0}", "Error" + ex.Message + ",Source:" + ex.Source + ",StackTrace:" + ex.StackTrace + ",InnerException:" + ex.InnerException));
                    }
                }
                objResponse.ResCode = "000";
                objResponse.ResDesc = "Success";
                dtUser = ds.Tables[0] != null ? ds.Tables[0] : null;
                if (dtUser != null && dtUser.Rows.Count > 0)
                {
                    //Changed on 20th-Sept-2017
                    AddProperty(objResponse, "mobileno", dtUser.Rows[0]["Mobileno"] != null ? dtUser.Rows[0]["Mobileno"].ToStr().Trim() : string.Empty);
                    //AddProperty(objResponse, "email", dtUser.Rows[0]["Email"] != null ? dtUser.Rows[0]["Email"].ToStr().Trim() : string.Empty);
                    AddProperty(objResponse, "email", dtUser.Rows[0]["Email"] != null ? new RC4(dtUser.Rows[0]["Email"].ToStr().Trim()).Decrypt() : string.Empty);
                    AddProperty(objResponse, "language", dtUser.Rows[0]["Language"] != null ? dtUser.Rows[0]["Language"].ToStr().Trim() : string.Empty);
                }

                dtUserMeta = ds.Tables[1] != null ? ds.Tables[1] : null;
                if (dtUserMeta != null && dtUserMeta.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtUserMeta.Rows)
                    {
                        if (dr["META_NAME"] == null || dr["META_NAME"].ToString().Trim().Length == 0)
                            continue;
                        //Changed on 20th-Sept-2017
                        if (dr["META_NAME"].ToStr().Trim().ToLower() == "aadhar")
                            AddProperty(objResponse, dr["META_NAME"].ToStr().Trim(), dr["META_VALUE"] != null ? new RC4(dr["META_VALUE"].ToStr().Trim()).Decrypt() : string.Empty);
                        else
                            AddProperty(objResponse, dr["META_NAME"].ToStr().Trim(), dr["META_VALUE"] != null ? dr["META_VALUE"].ToStr().Trim() : string.Empty);
                    }
                }
                return objResponse;
            }

            else if (retVal.ToStr() == "2")
            {
                return new Response
                {
                    ResCode = "100",
                    ResDesc = "Your Account is deleted,to countinue further please register again!"
                };
            }
            else
            {
                return new Response
                {
                    ResCode = "1",
                    ResDesc = "Invalid Credentials"
                };
            }
        }
        catch (Exception ex)
        {
            LogData.Write("User", "Auth", LogMode.Excep, ex, string.Format("User => UserAuthentication: Ex:{0}", ex.Message));
            return new Response
            {
                ResCode = "1",
                ResDesc = "We are unable to process your request"
            };
        }
        finally
        {
            //if (lStart > 0)
            //    lTimeTaken = (DateTime.Now.Ticks - lStart) / 10000;
            //Log objLog = new Log();
            //objLog.RefID = objRequest.Tid;
            //objLog.Channel = objRequest.Channel;
            //objLog.MobileNo = objRequest.MobileNo;
            //objLog.ServiceName = "USER";
            //objLog.ServiceCode = "1";
            //objLog.MethodName = "UserAuthentication";
            //objLog.SubService = "USER";
            //objLog.DigitalId = objRequest.DigitalId;
            //try { objLog.Request = JsonConvert.SerializeObject(objRequest); }
            //catch { objLog.Request = objRequest.ToString(); }
            //try { objLog.Response = JsonConvert.SerializeObject(objResponse); }
            //catch { objLog.Response = objResponse.ToString(); }
            //objLog.TimeTaken = lTimeTaken.ToString();
            //objLog.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //objLog.IP = string.Empty;
            //objLog.LogMessage("DEPTLOGS");
            //objLog = null;
            //objRequest = null;
            //objRequest = null;
            //ds = null;
            //dtUser = null;
            //dtUserMeta = null;
        }
    }

    private class JsonConvert
    {
    }
}
