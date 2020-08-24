using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
namespace BL
{
    public class ClassBL
    {
        mathEntities3 db = new mathEntities3();
        public bool Exist(string u, int p)
        {
            var answer = db.Users.Where(x => x.UserName == u && x.Userpassword == p).Select(x => x.UserName).Any();
            if (answer)
            {
                return true;
            }
            else
                return false;
        }
        Questions q;
        List<Answers> an;
        public Questions exerciseReturn10()
        {
            q = db.Questions.Where(y => y.ID < 11 && y.Percent == 10).Select(y => y).OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return q;
        }
        public Questions exerciseReturn6()
        {
            q = db.Questions.Where(y => y.ID < 11 && y.Percent == 6).Select(y => y).OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return q;
        }
        public Questions exerciseReturnRB()
        {
            q = db.Questions.Where(y => y.ID > 11).Select(y => y).OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return q;
        }
        public List<Answers> answerA(int id)
        {
            an = db.Answers.Where(y => y.QuestionID == id).ToList();
            return an;
        }
        public void save(int uP, int m)
        {
            using(mathEntities3 d = new mathEntities3())
            {
                
                History history = new History
                {
                    Userpassword = uP,
                    TestDate = DateTime.Now,
                    Mark = m,
                };
                d.History.Add(history);
                d.Entry(history).State = System.Data.Entity.EntityState.Modified;
                d.SaveChanges();
            }
        }
    }
}