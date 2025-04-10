namespace ConsoleProject__TextRPG_PR2_Park
{
    public static class SFX
    {
        private static Dictionary<char, (int freq, int dur)> soundMap = new Dictionary<char, (int, int)>
    {
    { ':', (800, 100) },
    { '-', (300, 150) },
    { '#', (100, 50) },  // 벽 부딪힘
    { 'W', (900, 100) },
    { 'a', (660, 80) },
    { 'n', (440, 80) },
    { '!', (1000, 100) },
    { 'I', (880, 200) },
        };

        public static void Play(char tile)
        {
            if (soundMap.TryGetValue(tile, out var sound))
            {
                Console.Beep(sound.freq, sound.dur);
            }
        }
        public static void PlayAt(char[,]map, int x, int y)
        {
            if(x>=0&&y>0 && y<map.GetLength(0)&&x<map.GetLength(1))
            {
                Play(map[x, y]);
            }
        }
    }
}
