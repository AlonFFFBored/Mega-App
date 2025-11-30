using Library_Mega_App;
using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ViewModel
{
    public class Membership_DB : UsersDB
    {
        public override BaseEntity NewEntity()
        {
            throw new NotImplementedException();
        }
        public Membership_List SelectAll()
        {
            command.CommandText = $"SELECT Membership.Join_Date, Membership.Birthday_Day, Users.ID, Users.Username, Users.Email, Users.Passkey, Users.Role\r\nFROM" +
                $"(Users INNER JOIN\r\n" +
                $"Membership ON Users.ID = Membership.ID)";

            Membership_List membership_list = new Membership_List(base.Select());
            return membership_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Membership m = entity as Membership;
            m.Join_Date = DateTime.Parse(reader["join_date"].ToString());
            m.Birthday_Date = DateTime.Parse(reader["birthday_date"].ToString());
            base.CreateModel(entity);
            return entity;
        }
        static private Membership_List list = new Membership_List();

        public static Membership SelectById(int id)
        {
            Membership_DB db = new Membership_DB();
            list = db.SelectAll();
            Membership m = list.Find(item => item.Id == id); return m;

        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Membership m = entity as Membership;
            if (m != null)
            {
                string sqlStr = $"DELETE FROM Membership where id=@mid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mid", m.Id));
            }
        }

            public override void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity !=  null & entity.GetType() == reqEntity.GetType())
                {
                    deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                    deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
                }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Membership m = entity as Membership;
            if (m != null)
            {
                string sqlStr = $"Insert INTO Membership (ID,Join_Date,Birthday_Day) VALUES (@mID,@mJoin_Date,@mBirthday_Date)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mID", m.Id));
                command.Parameters.Add(new OleDbParameter("@mJoin_Date", m.Join_Date));
                command.Parameters.Add(new OleDbParameter("@mBirthday_Date", m.Birthday_Date));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Membership m= entity as Membership;
            if (m != null)
            {
                string sqlStr = $"UPDATE Videos SET MembershipJoinDate=@mJoinDate,MembershipBirthdayDate=@mBirthdayDate WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mJoinDate", m.Join_Date));
                command.Parameters.Add(new OleDbParameter("@mBirthdayDate", m.Birthday_Date));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Membership member = entity as Membership;
            if (member != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

    }
}
