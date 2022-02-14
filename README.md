# Mô phỏng thuật toán sắp xếp
Sắp xếp là quá trình bố trí lại các phần tử trong một tập hợp theo một trình tự nào đó nhằm mục đích giúp quản lý và tìm kiếm các phần tử dễ dàng và nhanh chóng hơn.

## Danh sách thuật toán: 
### 1. Bubble Sort
:book: ***Ý tưởng***
- Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo.
- Ở lần xử lý thứ i có vị trí đầu dãy là i.
- Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.

:heavy_check_mark: ***Đánh giá***
- Số lượng các phép so sánh xảy ra không phụ thuộc vào tình trạng của dãy số ban đầu.
- Số lượng phép hoán vị thực hiện tùy thuộc vào kết quả so sánh.

:x: ***Khuyết điểm***
- Không nhận diện được tình trạng dãy đã có thứ tự  hay có thứ tự từng phần.
- Các phần tử nhỏ được đưa về vị trí đúng rất nhanh, trong khi các phần tử lớn lại được đưa về vị trí đúng rất chậm.

### 2. Interchange Sort
:blue_book: ***Khái niệm nghịch thế***
- Xét một mảng các số a[0], a[1], …, a[n-1]
- Nếu có `i < j` và `a[i] > a[j]`, thì ta gọi đó là một nghịch thế.
- Mảng chưa sắp xếp sẽ có nghịch thế.
> *Lưu ý: Mảng đã có thứ tự sẽ không chứa nghịch thế* `a[0] <= a[1] <= … <= [n -1]`

:notebook: ***Nhận xét***
- Để sắp xếp một dãy số, ta có thể xét các nghịch thế có trong dãy và làm triệt tiêu dần chúng đi.

:book: ***Ý tưởng***
- Xuất phát từ đầu dãy, tìm tất cả nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi chỗ phần tử này với phần tử tương ứng trong cặp nghịch thế. Lặp lại xử lý trên với các phần tử tiếp theo trong dãy.

:heavy_check_mark: ***Đánh giá***
- Số lượng các phép so sánh xảy ra không phụ thuộc vào tình trạng của dãy số ban đầu.
- Số lượng phép hoán vị thực hiện tùy thuộc vào kết quả so sánh.

### 3. Selection Sort
:notebook: ***Nhận xét***
- Mảng có thứ tự thì `a[i] = min(a[i], a[i+1], …, a[n-1])`

:book: ***Ý tưởng*** 
- Mô phỏng một trong những cách sắp xếp tự nhiên nhất trong thực tế:
  - Chọn phần tử nhỏ nhất trong n phần tử ban đầu, đưa phần tử này về vị trí đúng là đầu dãy hiện hành.
  - Xem dãy hiện hành chỉ còn n-1 phần tử của dãy ban đầu, bắt đầu từ vị trí thứ 2; lặp lại quá trình trên cho dãy hiện hành... đến khi dãy hiện hành chỉ còn 1 phần tử.

:heavy_check_mark: ***Đánh giá***
- Ở lượt thứ  i, cần  (n-i) lần so sánh để xác định phần tử nhỏ nhất hiện hành.
- Số lượng phép so sánh không phụ thuộc vào tình trạng của dãy số ban đầu.

### 4. Quick Sort
:blue_book: ***Lý thuyết***
- Quick Sort là một giải thuật hiệu quả cao và dựa trên việc chia mảng dữa liệu thành các mảng nhỏ hơn. Giải thuật sắp xếp nhanh chia mảng thành hai phần bằng cách so sánh từng phần tử của mảng với một phần tử được chọn gọi là phần tử chốt (pivot): một mảng bao gồm các phần tử nhỏ hơn hoặc bằng phần tử chốt và mảng còn lại bao gồm các phần tử lớn hơn hoặc bằng phần tử chốt.
- Tiến trình chia này diễn ra tiếp tục cho tới khi độ dài của các mảng con đều bằng 1. Giải thuật sắp xếp nhanh tỏ ra khá hiệu quả với các tập dữ liệu lớn khi mà độ phức tạp trường hợp trung bình và trường hợp xấu nhất là O(nlogn) với n là số phần tử.
- Kỹ thuật chọn phần tử chốt ảnh hưởng khá nhiều đến khả năng rơi vào các vòng lặp vô hạn đối với các trường hợp đặc biệt. Tốt nhất là chọn phần tử chốt (pivot) nằm ở trung vị của danh sách. Khi đó, sau log2(n) lần chia chúng ta sẽ đạt tới kích thước các mảng con bằng 1.

:book: ***Ý tưởng*** 
- Khởi tạo biến l và r là chỉ số đầu và cuối của đoạn cần sắp xếp, khởi tạo `l = 0` và `r = n-1`
- Xác định phần tử chốt trong dãy `p = a[(l+r)/2]`
- Sử dụng biến i và biến j để chia dãy thành 2 phần. Biến i sẽ chạy từ l đến r và biến j sẽ chạy từ r về l. Nếu phát hiện `a[i] >= p` và `a[j] <= p` thì dừng lại và tráo đổi ví trí của chúng.

### 5. Insertion Sort
:notebook: ***Nhận xét***
- Mọi dãy a[0], a[1], ..., a[n-1] luôn có i-1 phần tử đầu tiên a[0], a[1], ..., a[i-2] đã có thứ tự (i ≥ 2)

:book: ***Ý tưởng***
- Tìm cách chèn phần tử a[i] vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a[0], a[1], ..., a[n-1] trở nên có thứ tự.
- Vị trí này chính là pos thỏa: `a[pos-1] <= a[i ] < a[pos] (1 <= pos <= i)`

:heavy_check_mark: ***Đánh giá***
- Giải thuật thực hiện tất cả N-1 vòng lặp tìm pos, do số lượng phép so sánh và dời chỗ này phụ thuộc vào tình trạng của dãy số ban đầu, nên chỉ có thể ước lược trong từng trường hợp như sau:

## :framed_picture: Danh sách hình ảnh
### Trang chủ
<img src="answer\home.png" alt="Trang chủ"/>
