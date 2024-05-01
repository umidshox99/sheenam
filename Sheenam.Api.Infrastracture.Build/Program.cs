using ADotNet.Models.Pipelines.GithubPipelines.DotNets;

var githubPipeline = new GithubPipeline
{
  Name = "Sheenam Build Pipeline",
  OnEvents = new Events
  {
   PullRequest = new PullRequestEvent
   {
     Branches = new []{"master"}
     
   },
  }
  
  
};
