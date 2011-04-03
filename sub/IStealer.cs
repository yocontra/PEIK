namespace sub
{
    interface IStealer
    {
        string Data { get; set; }
        void Collect();
    }
}