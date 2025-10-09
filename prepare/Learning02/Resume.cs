public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //_jobs[0].DisplayJob();
        //_jobs[1].DisplayJob();
        // before the sample solution
        // I should have used a foreach statement as it would let me add as many jobs as I had


        //Made after viewing the sample solution
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
        //
    }
}