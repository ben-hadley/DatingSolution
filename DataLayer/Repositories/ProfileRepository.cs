using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Repositories
{
    class ProfileRepository
    {
        public dynamic getAll()
        {
            using (var context = new DatingSiteEntities())
            {
                return context.USERS.ToList();
            }

        }

        public USERS getUser (int id)
        {
            using (var context = new DatingSiteEntities())
            {
                return context.USERS.FirstOrDefault(x => x.AID == id);
            }
        }

        public void addUser (USERS newUser)
        {
            using (var context = new DatingSiteEntities())
            {
                context.USERS.Add(newUser);
                context.SaveChanges();
            }
        }
    }
}
