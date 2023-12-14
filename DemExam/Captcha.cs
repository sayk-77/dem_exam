using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace DemExam
{
    public partial class Captcha : Form
    {
        private List<string>  _textCaptcha;
        private Bitmap _pictureCaptcha;
        private bool _captchaAccess;
        public Captcha()
        {
            InitializeComponent();
            _pictureCaptcha = CreateImageCaptcha();
            pictureCaptcha.Image = _pictureCaptcha;
        }
        
        private Bitmap CreateImageCaptcha()
        {
            const int heightPicture = 50;
            const int widthPicture = 200;
            Random rnd = new Random();
            Bitmap picture = new Bitmap(widthPicture, heightPicture);

            int xpos = 30;
            int ypos = 25;

            Brush[] colors =
            {
                Brushes.Aqua,
                Brushes.Brown,
                Brushes.Blue,
                Brushes.Chocolate
            };

            Graphics g = Graphics.FromImage((Image)picture);
            g.Clear(Color.White);
            
            const string symbols = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            _textCaptcha = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                _textCaptcha.Add(symbols[rnd.Next(symbols.Length)].ToString());
                
                g.TranslateTransform(xpos, ypos);
                g.RotateTransform(rnd.Next(90));
                g.DrawString(_textCaptcha[i], 
                    new Font("Comic Sans MS", 16),
                    colors[rnd.Next(colors.Length)],
                    new PointF(0, 0)
                );
                g.ResetTransform();
                xpos += 30;
            }
            
            g.DrawLine(Pens.Black,
                new Point(0,0),
                new Point(rnd.Next(widthPicture), rnd.Next(heightPicture))
            );
            
            g.DrawLine(Pens.Black,
                new Point(widthPicture, heightPicture),
                new Point(rnd.Next(widthPicture), rnd.Next(heightPicture))
            );
            
            return picture;
        }

        private void sendCaptcha_Click(object sender, EventArgs e)
        {
            _captchaAccess = userTextCaptcha.Text == string.Join("",_textCaptcha);
            this.Close();
        }

        public bool GetCaptchaAccess()
        {
            return _captchaAccess;
        }
    }
}