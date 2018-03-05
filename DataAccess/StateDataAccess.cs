using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class StateDataAccess : BaseDataAccess
    {
        public StateDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<State> GetAll()
        {
            return this.Context.State;
        }

        public IQueryable<State> GetById(int id)
        {
            return this.Context.State.Where(s => s.IdState == id);
        }

        public State Add(State state)
        {
            this.Context.Entry(state).State = EntityState.Added;
            this.Context.SaveChanges();

            return state;
        }

        public State Update(State state)
        {
            this.Context.Entry(state).State = EntityState.Modified;
            this.Context.SaveChanges();

            return state;
        }

        public void Delete(State state)
        {
            this.Context.Entry(state).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}