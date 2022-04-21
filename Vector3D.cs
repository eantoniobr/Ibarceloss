 public class Vector3D
    {
        public double x, y, z;
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D normalize()
        {
            return this.divideScalar(this.length());
        }

        public Vector3D multiplyScalar(double value)
        {

            this.x *= value;
            this.y *= value;
            this.z *= value;

            return this;
        }

        public Vector3D add(Vector3D vector3d)
        {

            this.x += vector3d.x;
            this.y += vector3d.y;
            this.z += vector3d.z;

            return this;
        }

        public Vector3D add3D(double x, double y, double z)
        {

            this.x += x;
            this.y += y;
            this.z += z;

            return this;
        }

        public Vector3D sub(Vector3D vector3d)
        {

            this.x -= vector3d.x;
            this.y -= vector3d.y;
            this.z -= vector3d.z;

            return this;
        }

        public Vector3D sub3D(double x, double y, double z)
        {

            this.x -= x;
            this.y -= y;
            this.z -= z;

            return this;
        }

        public Vector3D divideScalar(double value)
        {
            if (value != 0)
            {
                double scalar = 1 / value;

                this.x *= scalar;
                this.y *= scalar;
                this.z *= scalar;
            }
            else
            {
                this.x = this.y = this.z = 0;
            }

            return this;
        }

        public Vector3D cross(Vector3D vector3d)
        {

            double x = this.x, y = this.y, z = this.z;

            this.x = y * vector3d.z - z * vector3d.y;
            this.y = z * vector3d.x - x * vector3d.z;
            this.z = x * vector3d.y - y * vector3d.x;

            return this;
        }

        public double length()
        {
            return Math.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));
        }

        public Vector3D clone()
        {
            return new Vector3D(this.x, this.y, this.z);
        }
    }