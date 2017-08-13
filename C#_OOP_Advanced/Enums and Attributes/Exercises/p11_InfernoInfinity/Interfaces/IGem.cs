namespace p11_InfernoInfinity.Interfaces
{
    using Enums;

    public interface IGem
    {
        IStat Stat { get; }
        Clarity Clarity { get; }
    }
}