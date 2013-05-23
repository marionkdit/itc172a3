using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class EightBall
{
	// To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
	// To create an operation that returns XML,
	//     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
	//     and include the following line in the operation body:
	//         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";

        [OperationContract]
        public string getQuote(int i){
            string[] theQuotes = {"Yesterday is gone, tomorrow is not yet here, we only have today, so let us begin.  -Mother Teresa", "Great spirits have always encountered violent opposition from mediocre minds. -Albert Einstein", "Great minds discuss ideas; average minds discuss events; small minds discuss people.  -Eleanor Roosevelt", "There is no greater agony than bearing an untold story inside you.", "The medocre teacher tells.  The good teacher explains.  The superior teacher demonstrates.  The great teacher inspires.  -William Arthur Ward"};
            string quotation = theQuotes[i];
		    return quotation;
        }
	}

	// Add more operations here and mark them with [OperationContract]

