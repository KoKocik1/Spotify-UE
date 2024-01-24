import spotipy
from spotipy.oauth2 import SpotifyClientCredentials
from dotenv import dotenv_values
from supabase import create_client, Client

secrets = dotenv_values('secret.env')

sp = spotipy.Spotify(auth_manager=SpotifyClientCredentials(client_id=secrets['CLIENT_ID'],
                                                           client_secret=secrets['CLIENT_SECRET']))

results = sp.playlist_items(playlist_id='37i9dQZEVXbN6itCcaL3Tt', limit=10, market='PL',)

supabase: Client = create_client(secrets['DATABASE_URL'], secrets['DATABASE_KEY'])

position=0

for item in results['items']:

        item=item['track']
        album=item['album']
        arists=item['artists']

        position=position+1

        artistData=[]
        for artist in arists:
                artistData.append(artist['name'])

        while(len(artistData)<4):
             artistData.append("")
        
        data = {
        "position": position,
        "song_name": item['name'],
        "duration": item['duration_ms'],
        "explicit": item['explicit'],
        "popularity": item['popularity'],
        "album_type": album['album_type'],
        "album_name": album['name'],
        "spotify_id": item['id'],
        "artist_1": artistData[0],
        "artist_2": artistData[1],
        "artist_3": artistData[2],
        "artist_4": artistData[3]
        }
        
        supabase.table('Top50Poland').insert(data).execute()