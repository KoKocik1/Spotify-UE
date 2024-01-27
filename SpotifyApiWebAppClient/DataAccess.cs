using Dapper;
using SpotifyApiWebApp.Models;
using Supabase.Gotrue;
using System.Data;

namespace SpotifyApiWebApp
{
    public class DataAccess
    {
        private readonly string _url = "https://wxmwhdwkkqwepbvuqcij.supabase.co";
        private readonly string _key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Ind4bXdoZHdra3F3ZXBidnVxY2lqIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDEzNjg3MjEsImV4cCI6MjAxNjk0NDcyMX0.VthShuh1x5XwmleDxTOpx94DSd6g9TKBMqzevRZWTHI";
        private Supabase.Client _supaBaseClient;

        public DataAccess()
        {
            this._supaBaseClient = this.SupaBaseClientInit();
        }

        public async Task<List<SongDto>> GetAllSongs()
        {
            await this._supaBaseClient.InitializeAsync();

            var results = await this._supaBaseClient.From<SongDto>().Get();

            return results.Models;
        }

        private Supabase.Client SupaBaseClientInit() 
        {
            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabaseClient = new Supabase.Client(this._url, this._key, options);

            return supabaseClient;
        }
    }
}
