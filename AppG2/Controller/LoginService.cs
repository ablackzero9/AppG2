using AppG2.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    public class LoginService
    {
        public static List<Login> GetUser(string pathDataFile)
        {
            if (File.Exists(pathDataFile))
            {
                List<Login> listUser = new List<Login>();

                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    Login login = new Login
                    {
                        Account = rs[0],
                        Password = rs[1],
                        Username = rs[2],
                    };
                    listUser.Add(login);
                }
                return listUser;
            }
            else return null;
        }
    }
}