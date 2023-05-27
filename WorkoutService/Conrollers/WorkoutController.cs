using Common;
using Microsoft.AspNetCore.Mvc;
using WorkoutService.Database;

namespace WorkoutService.Conrollers;


[ApiController]
[Route("[controller]")]
public class WorkoutController : ControllerBase
{
    private WorkoutCollection _workout;

    public WorkoutController()
    {
        _workout = new WorkoutCollection();
    }
    
    [HttpGet("{id}")]
    public  WorkoutDTO GetWorkOutIntensity(int id)
    {
        var workout = _workout.GetWorkOutIntensity(id);
        var newworkout = new WorkoutDTO
        {
            Intensity = workout.WorkOutIntensity
        };
        return newworkout;
    }
}