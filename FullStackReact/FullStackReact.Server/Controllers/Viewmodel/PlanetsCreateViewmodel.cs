namespace FullStackReact.Server.Controllers.Viewmodel
{
    public class PlanetsCreateViewmodel
    
        public string Name { get; set; } = string.Empty;
        public string Descriptions { get; set; } = string.Empty;
        public string Types { get; set; } = string.Empty;
        public string Mass { get; set; }
        public string Description { get; internal set; }
        public string Type { get; internal set; }
    }
}
