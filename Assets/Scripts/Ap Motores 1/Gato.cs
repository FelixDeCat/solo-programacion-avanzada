public class Gato
{
    int patas = -1;

    public Gato()
    {
        /// gato por default, tiene 4 patas
        
        patas = 4;
    }

    /// Gato con patas personalizables
    public Gato(int patas)
    {
        this.patas = patas;
    }
}