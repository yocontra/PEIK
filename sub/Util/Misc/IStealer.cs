namespace sub.Util.Misc
{
    interface IStealer
    {
        string Name { get; set; }
        string Data { get; set; }
        void Collect();
    }
}