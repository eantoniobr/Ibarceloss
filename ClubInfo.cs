 public static ClubInfo getClubInfo(int type)
        {
            switch (type)
            {
                case (int) ClubInfoEnum._1W:
                    return new ClubInfo(ClubTypeEnum.Wood, 0.55, 1.61, 236.0, 10.0, 230.0);
                case (int) ClubInfoEnum._2W:
                    return new ClubInfo(ClubTypeEnum.Wood, 0.50, 1.41, 204.0, 13.0, 210.0);
                case (int) ClubInfoEnum._3W:
                    return new ClubInfo(ClubTypeEnum.Wood, 0.45, 1.26, 176.0, 16.0, 190.0);
                case (int) ClubInfoEnum._2I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.45, 1.07, 161.0, 20.0, 180.0);
                case (int) ClubInfoEnum._3I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.45, 0.95, 149.0, 24.0, 170.0);
                case (int) ClubInfoEnum._4I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.45, 0.83, 139.0, 28.0, 160.0);
                case (int) ClubInfoEnum._5I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.45, 0.73, 131.0, 32.0, 150.0);
                case (int) ClubInfoEnum._6I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.41, 0.67, 124.0, 36.0, 140.0);
                case (int) ClubInfoEnum._7I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.36, 0.61, 118.0, 40.0, 130.0);
                case (int) ClubInfoEnum._8I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.30, 0.57, 114.0, 44.0, 120.0);
                case (int) ClubInfoEnum._9I:
                    return new ClubInfo(ClubTypeEnum.Iron, 0.25, 0.53, 110.0, 48.0, 110.0);
                case (int) ClubInfoEnum.PW:
                    return new ClubInfo(ClubTypeEnum.PW, 0.18, 0.49, 107.0, 52.0, 100.0);
                case (int) ClubInfoEnum.SW:
                    return new ClubInfo(ClubTypeEnum.PW, 0.17, 0.42, 93.0, 56.0, 80.0);
                case (int) ClubInfoEnum.PT1:
                    return new ClubInfo(ClubTypeEnum.PT, 0.00, 0.00, 30.0, 0.00, 20.0);
                case (int) ClubInfoEnum.PT2:
                    return new ClubInfo(ClubTypeEnum.PT, 0.00, 0.00, 21.0, 0.00, 10.0);
                default:
                    return null;
            }
        }

        public ClubInfo(ClubTypeEnum type, double rotationSpin, double rotationCurve, double powerFactor, double degree, double powerBase)
        {
            this.type = type;
            this.rotationSpin = rotationSpin;
            this.rotationCurve = rotationCurve;
            this.powerFactor = powerFactor;
            this.degree = degree;
            this.powerBase = powerBase;
        }
    }