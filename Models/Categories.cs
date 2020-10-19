using System;
using System.Collections.Generic;

namespace SwaggerAPI.Models
{
    public class Categories
    {
        public List<string> Category { get; set; }
        public int total { get; set; }
        public Result[] result { get; set; }
    }
}
public class Result
{
    public string[] categories { get; set; }
    public string created_at { get; set; }
    public string icon_url { get; set; }
    public string id { get; set; }
    public string updated_at { get; set; }
    public string url { get; set; }
    public string value { get; set; }
}

