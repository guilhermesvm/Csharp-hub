Band band = new Band("Blink-182");

Music music1 = new Music(band, "Dammit")
{
    Duration = 213,
    Available = true,
};

Music music2 = new Music(band, "Whats My Age Again?")
{
    Duration = 123,
    Available = true,
};

Album album1 = new Album("Enema Of The State");
album1.AddMusic(music1);
album1.AddMusic(music2);

band.AddAlbum(album1);

band.ShowBandsDiscography();
album1.ShowAlbumMusics();
music1.ShowMusicProperties();
music2.ShowMusicProperties();


Podcast inteligenciaLTDA = new Podcast("Vilela", "Inteligência Limitada");
Episode ep1 = new Episode(2, "AI and Machine Learning", 180);
ep1.AddGuests("Guilherme Machado");

Episode ep2 = new Episode(3, "Backend", 120);
ep2.AddGuests("Giuliana Bordignon");
ep2.AddGuests("Guilherme Machado");

inteligenciaLTDA.AddEpisode(ep1);
inteligenciaLTDA.AddEpisode(ep2);

inteligenciaLTDA.ShowPodcastDetails();



