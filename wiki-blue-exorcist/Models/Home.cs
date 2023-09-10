using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.SignalR;

namespace wiki_blue_exorcist.Models;

public class Home {
    public string Title { get; set;}

    public string Sinopse { get; set;}

    public string Image { get; set;}

    public int Quantidade {get; set;}
}