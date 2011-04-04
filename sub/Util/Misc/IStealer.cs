namespace sub.Util.Misc
{
    interface IStealer
    {
        string Data { get; set; }
        void Collect();
    }
}