
namespace Factory
{
    public abstract class Barrack
    {
        Unit unit;

        public Unit orderUnit (string role)
        {
            unit = CreateUnit(role);

            return unit;
        }

        protected abstract Unit CreateUnit(string role);
    }
}
