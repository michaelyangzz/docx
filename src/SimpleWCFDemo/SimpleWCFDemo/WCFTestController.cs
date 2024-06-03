using Microsoft.AspNetCore.Mvc;

namespace SimpleWCFDemo;

public class Envelope
{
    public Body? Body { get; set; }
}

public class ResponseEnvelope
{
    public ResponseBody? Body { get; set; }
}

public class Body
{
    public WCFRequest? Request { get; set; }
}

public class ResponseBody
{
    public WCFRequest? Response { get; set; }
}

public class WCFRequest
{
    public string? Id { get; set; }
    public string? Name { get; set; }

}

public class WCFTestController : ControllerBase
{
    [HttpPost("abc/abc.svc")]
    [Consumes("text/xml")]
    [Produces("text/xml")]
    public IActionResult Post([FromBody] Envelope request)
    {
        Console.WriteLine($"ID: {request?.Body?.Request?.Id}");
        Console.WriteLine($"Name: {request?.Body?.Request?.Name}");

        return Ok(new ResponseEnvelope
        {
            Body = new ResponseBody()
            {
                Response = new WCFRequest
                {
                    Id = "1-PV4BGNV",
                    Name = "Success"
                }
            }
        });
    }
}