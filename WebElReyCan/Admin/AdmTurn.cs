using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebElReyCan.Models;
using System.Data.Entity;


namespace WebElReyCan.Admin
{
    public static class AdmTurn
    {
        private static TurnoDbContext context = new TurnoDbContext();

        public static List<Turno> List()
        {
            var turns = context.Turnos.ToList();
            return turns;
        }

        public static List<Turno> ListByDay (DateTime day)
        {
            var turns = (from t in context.Turnos
                         where t.Date == day
                         select t).ToList();
            return turns;
        }

        public static List<Turno> ListByName (string name)
        {
            var turns = (from t in context.Turnos
                         where t.PetName == name
                         select t).ToList();

            return turns;
        }

        public static List<Turno> ListByCell (string cell)
        {
            var turns = (from t in context.Turnos
                         where t.CellNumber == cell
                         select t).ToList();

            return turns;
        }

        public static void Create(Turno turn)
        {
            context.Turnos.Add(turn);
            context.SaveChanges();
        }

        public static Turno SearchByID ( int id)
        {
            Turno turn = context.Turnos.Find(id);
            context.Entry(turn).State = EntityState.Detached;
            return turn;
        }


        public static void Edit(Turno turn)
        {
            context.Turnos.Attach(turn);
            context.SaveChanges();
        }
    }
}