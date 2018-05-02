using Business;
using Business.Messaging.State;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FightTeamControl.Controllers
{
    public class StateController : BaseController
    {
        public StateController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/State/GetAllStates")]
        public List<State> GetAllStates()
        {
            var business = StateBusiness.Instance;
            var request = new GetAllStatesRequest(this.Context);
            var states = business.GetAllStates(request);

            return states;
        }

        [HttpGet]
        [Route("api/State/GetStateById")]
        public State GetStateById(int idState)
        {
            var business = StateBusiness.Instance;
            var request = new GetStateByIdRequest(this.Context);
            request.IdState = idState;

            var country = business.GetStateById(request);

            return country;
        }

        [HttpPost]
        [Route("api/State/AddState")]
        public State AddState([FromBody]State state)
        {
            if (state != null)
            {
                var business = StateBusiness.Instance;
                var request = new AddStateRequest(this.Context);
                request.State = state;

                state = business.AddState(request);
            }

            return state;
        }

        [HttpPut]
        [Route("api/State/UpdateState")]
        public State UpdateState([FromBody]State state)
        {
            if (state != null)
            {
                var business = StateBusiness.Instance;
                var request = new UpdateStateRequest(this.Context);
                request.State = state;

                state = business.UpdateState(request);
            }

            return state;
        }

        [HttpDelete]
        [Route("api/State/DeleteState")]
        public void DeleteState(int idState)
        {
            var business = StateBusiness.Instance;
            var request = new DeleteStateRequest(this.Context);
            request.IdState = idState;

            business.DeleteState(request);
        }
    }
}