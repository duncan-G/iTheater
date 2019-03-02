namespace Server.Dtos {
    public class MovieListDto {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public bool privacy { get; set; }
        public string defaultImageUrl { get; set; }
        public string created { get; set; }
    }
}