using System.Drawing;

namespace SortingAlgorithmSimulation
{
    public class Content
    {
        public static int HEIGHT = 100; // Chiều cao lúc di chuyển
        public static int WIDTH_SIZE = 60; // Kích thước nút
        public static int HEIGHT_SIZE = 50; // Kích thước nút
        public static int DISTANCE = 20; //Khoảng cách giữa 2 nút

        // Random theo khoảng giá trị [RANDOM_START, RANDOM_END]
        public static int RANDOM_START = 0;
        public static int RANDOM_END = 100;

        // Định dạng nút khi bắt đầu.
        public static Color fillColor = Color.FromArgb(255, 120, 80);
        public static Color foreColor = Color.White;
        public static Color fillColorFinish = Color.FromArgb(255, 239, 100);
        public static Color foreColorFinish = Color.Black;

        // Thời gian Run
        public static int threadTime = 1;
    }
}
