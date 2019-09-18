using Entities;
using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleMemo.Models
{
    public class Model
    {
        //You don want to make it static, you instantiate once
        private Business bll = new Business();

        public List<Memo> GetList()
        {
            return bll.GetMemos();
        }

        public Memo getMemo(int m)
        {
            return bll.getMemo(m);
        }

        public void Insert(Memo m)
        {
            bll.AddRecord(m);
        }

        public void Remove(int m)
        {
            bll.Delete(m);
        }

        public void Edit(Memo newrecords)
        {
            bll.Update(newrecords);
        }

    }
}