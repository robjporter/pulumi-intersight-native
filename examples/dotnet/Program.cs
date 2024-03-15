using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Intersight = Pulumi.Intersight;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new Intersight.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

