using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstMVCProject.Data;

namespace MyFirstMVCProject.Models
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }

        public string SaveRegistration(RegistrationModel model)
        {
            MyFirstMVCProjectEntities db = new MyFirstMVCProjectEntities();
            string message = "";
            var saveReg = new tblRegistration()
            {
                Name = model.Name,
                Address = model.Address,
                City = model.City,
                MobileNo = model.MobileNo,
                EmailId = model.EmailId

            };

            db.tblRegistrations.Add(saveReg);
            db.SaveChanges();
            return message;
        }
    }

}