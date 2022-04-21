 public class Club
    {
        const double _00D19B98 = 0.0698131695389748;

        ClubTypeEnum type = ClubTypeEnum.Wood;
        public TypeDistanceEnum typeDistance { get; set; } = TypeDistanceEnum.BiggerOrEqual58;

        double rotationSpin = 0.55;     // Rotação spin
        double rotationCurve = 1.61;    // Rotação curva
        double powerFactor = 236;       // Power shot
        double degree = 10;             // Ângulo
        double powerBase = 230;         // Base power

        public Club()
        {

        }

        public void init (ClubInfo clubInfo)
        {
            this.init(
                clubInfo.type,
                clubInfo.rotationSpin,
                clubInfo.rotationCurve,
                clubInfo.powerFactor,
                clubInfo.degree,
                clubInfo.powerBase
            );
        }

        public void init (ClubTypeEnum type, double rotationSpin, double rotationCurve, double powerFactor, double degree, double powerBase)
        {
            this.type = type;
            this.rotationSpin = rotationSpin;
            this.rotationCurve = rotationCurve;
            this.powerFactor = powerFactor;
            this.degree = degree;
            this.powerBase = powerBase;
        }

        double getDregRad()
        {
            return this.degree * Math.PI / 180;
        }

        public double getPower(PowerPlayerOptions extraPower, double pwrSlot, int ps, double spin)
        {
            // Get auxpart
            // Get card
            // Get Mascot
            double pwrJard = 0;

            switch (this.type)
            {
                case ClubTypeEnum.Wood:
                    pwrJard = extraPower.total(ps) + getPowerShotFactory(ps) + ((pwrSlot - 15) * 2);

                    pwrJard *= 1.5;
                    pwrJard /= this.powerBase;
                    pwrJard += 1;
                    pwrJard *= this.powerFactor;

                    break;
                case ClubTypeEnum.Iron:
                    pwrJard = (
                        (getPowerShotFactory(ps) / this.powerBase + 1.0) *
                        this.powerFactor) + (extraPower.total(ps) *
                        this.powerFactor * 1.3) / this.powerFactor;

                    break;
                case ClubTypeEnum.PW:
                    switch(this.typeDistance)
                    {
                        case TypeDistanceEnum.Less10:
                        case TypeDistanceEnum.Less15:
                        case TypeDistanceEnum.Less28:
                            pwrJard = (
                                getPowerByDegree(this.getDregRad(), spin) *
                                (52.0 + (ps != 0 ? 28.0 : 0))) +
                                (extraPower.total(ps) * this.powerFactor) / this.powerBase;
                            break;
                        case TypeDistanceEnum.Less58:
                            pwrJard = (getPowerByDegree(this.getDregRad(), spin) * (80.0 + (ps != 0 ? 18.0 : 0))) + (extraPower.total(ps) * this.powerFactor) / this.powerBase;
                            break;
                        case TypeDistanceEnum.BiggerOrEqual58:
                            pwrJard = ((getPowerShotFactory(ps) / this.powerBase + 1.0) * this.powerFactor) + (extraPower.total(ps) * this.powerFactor) / this.powerBase;
                            break;
                    }
                    break;
                case ClubTypeEnum.PT:
                    pwrJard = this.powerFactor;
                    break;
            }

            return pwrJard;
        }

        public double getPowerByDegree(double degree, double spin)
        {
            return 0.5 + (0.5 * (degree + (spin * _00D19B98)) / 56 / 180 * Math.PI);
        }

        public double getPowerShotFactory(int ps)
        {
            double powerShotFactory = 0;
            switch (ps)
            {
                case (int)PowerShotFactoryEnum.OnePowerShot:
                    powerShotFactory = 10;
                    break;
                case (int)PowerShotFactoryEnum.TwoPowerShot:
                    powerShotFactory = 20;
                    break;
                case (int)PowerShotFactoryEnum.FifteenPowerShot:
                    powerShotFactory = 15;
                    break;
            }

            return powerShotFactory;
        }
    }