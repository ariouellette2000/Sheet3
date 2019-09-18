using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DB
    {
        public static int LastId=0;
        //You have to have access to the entity first so a link between Entity and DAL
        //Adding automatic value
        public static List<Memo> memos = new List<Memo>() {
            new Memo() {Id=0, F_Name="first", L_Name="test", Mobile_Phone="1111111", Active=true},
            new Memo() {Id=1, F_Name="second", L_Name="test", Mobile_Phone="2222222", Active=true}
        };
    }
}
