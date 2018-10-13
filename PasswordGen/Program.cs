using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGen
{
  class Program
  {
    static void Main(string[] args)
    {
      string folderName = @"c:\Users\blrus\Documents";

      string fileName = "newPassword.txt";

      var pathString = System.IO.Path.Combine(folderName, fileName);

      Guid g;
      g = Guid.NewGuid();
      System.IO.File.WriteAllText(pathString, g.ToString());
    }
  }
}
