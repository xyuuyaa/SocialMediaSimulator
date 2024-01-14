using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator
{
    public interface IUser
    {
        int accountId { get; set; }
        static int nextId;
        public static List<IUser> users = new List<IUser>();
    }
}
