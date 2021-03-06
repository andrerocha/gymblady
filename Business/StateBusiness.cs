﻿using Business.Messaging.State;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class StateBusiness : BaseBusiness<StateBusiness>
    {
        public List<State> GetAllStates(GetAllStatesRequest request)
        {
            List<State> states = null;

            if (request != null)
            {
                var dataAccess = new StateDataAccess(request.Context);                

                var statesQuery = dataAccess.GetAll();

                statesQuery = statesQuery.Include(s => s.Country);

                states = statesQuery.ToList();
            }

            return states;
        }

        public State GetStateById(GetStateByIdRequest request)
        {
            State state = null;

            if (request != null)
            {
                var dataAccess = new StateDataAccess(request.Context);

                var stateQuery = dataAccess.GetById(request.IdState);

                stateQuery = stateQuery.Include(s => s.Country);

                state = stateQuery.FirstOrDefault();
            }

            return state;
        }

        public State AddState(AddStateRequest request)
        {
            State state = null;

            if (request != null && request.State != null)
            {
                var dataAccess = new StateDataAccess(request.Context);

                state = dataAccess.Add(request.State);
            }

            return state;
        }

        public State UpdateState(UpdateStateRequest request)
        {
            State state = null;

            if (request != null && request.State != null)
            {
                var dataAccess = new StateDataAccess(request.Context);

                state = dataAccess.Update(request.State);
            }

            return state;
        }

        public void DeleteState(DeleteStateRequest request)
        {
            if (request != null)
            {
                var dataAccess = new StateDataAccess(request.Context);

                var state = dataAccess.GetById(request.IdState);

                dataAccess.Delete(state.FirstOrDefault());
            }
        }
    }
}