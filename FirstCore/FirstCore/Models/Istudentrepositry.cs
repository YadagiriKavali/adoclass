using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    interface Istudentrepositry
    {
        Student GetStudentById(int Id);
    }
}
