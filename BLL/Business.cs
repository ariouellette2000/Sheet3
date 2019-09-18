using Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Business
    {
        //First Need to access entities then DAL

        public List<Memo> GetMemos()
        {
            return DB.memos;
        }

        //Get specific memo
        public Memo getMemo(int m)
        {
            var records = DB.memos.Where(x => x.Id == m).Single();
            return records;
        }

        //Add method
        public void AddRecord(Memo m)
        {
            m.Id = DB.LastId++;
            m.Active = true;
            DB.memos.Add(m);
        }

        //Delete method
        public void Delete(int m)
        {
            var records = getMemo(m);
            records.Active=false;
        }

        //Update the record
        public void Update(Memo m)
        {
            m.Active=true;
            DB.memos[m.Id]= m;
        }

 
        
    }
}
