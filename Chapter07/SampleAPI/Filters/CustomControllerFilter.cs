using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleAPI.Filters {
    public class CustomControllerFilter : ActionFilterAttribute {

        public override void OnActionExecuting(ActionExecutingContext context) {
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context) {
            base.OnActionExecuted(context);
        }
    }
}
