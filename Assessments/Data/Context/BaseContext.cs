using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class BaseContext : DbContext
    {
        public BaseContext() : base (@"Data Source=192.168.0.126;Initial Catalog=DbAssessments;Persist Security Info=True;User ID=Assessments;Password=assessments@123")
        {

        }
    }
}
