namespace MyBuildpack
{
    public abstract class SupplyBuildpack : Buildpack
    {
        protected override int DoRun(string[] args)
        {
            var command = args[0];
            switch (command)
            {
                case "supply":
                    Apply(args[1], args[2], args[3], int.Parse(args[4]));
                    break;
                default:
                    return base.DoRun(args);
            }

            return 0;
        }
    }
}