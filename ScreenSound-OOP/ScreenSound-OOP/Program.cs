Band band = new Band("Blink-182");

Song song1 = new Song(band, "Dammit")
{
    Duration = 213,
    Available = true,
};

Song song2 = new Song(band, "Whats My Age Again?")
{
    Duration = 123,
    Available = true,
};

Album album1 = new Album("Enema Of The State");
album1.AddSong(song1);
album1.AddSong(song2);

band.AddAlbum(album1);

band.ShowBandsDiscography();
album1.ShowAlbumSongs();
song1.ShowSongProperties();
song2.ShowSongProperties();


Podcast inteligenciaLTDA = new Podcast("Vilela", "Inteligência Limitada");
Episode ep1 = new Episode(2, "AI and Machine Learning", 180);
ep1.AddGuests("Guilherme Machado");

Episode ep2 = new Episode(3, "Backend", 120);
ep2.AddGuests("Giuliana Bordignon");
ep2.AddGuests("Guilherme Machado");

inteligenciaLTDA.AddEpisode(ep1);
inteligenciaLTDA.AddEpisode(ep2);

inteligenciaLTDA.ShowPodcastDetails();



