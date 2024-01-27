using Supabase.Gotrue;

internal class ClientOptions<T> : ClientOptions
{
    public string Url { get; set; }
    public Dictionary<string, string> Headers { get; set; }
}