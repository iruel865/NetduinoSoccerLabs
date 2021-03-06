using System.Threading;
using Netduino.Foundation.Servos;

namespace SoccerSample
{
    public class PlayerController
    {
        protected bool _kickRight;
        protected Servo _servo;

        public PlayerController(Servo servo)
        {
            _servo = servo;
            _servo.RotateTo(0);
        }

        public void Kick()
        {
            Thread _animationThread = new Thread(() =>
            {
                _kickRight = !_kickRight;

                if (_kickRight)
                {
                    _servo.RotateTo(180);
                }
                else
                {
                    _servo.RotateTo(0);
                }
            });
            _animationThread.Start();
        }
    }
}
