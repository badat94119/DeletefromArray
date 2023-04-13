// Bước 1: Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước.
int[] array = new int[] { 1, 2, 3, 4, 5 };

// Bước 2: Nhập X là phần tử cần xoá
int X = 3;

// Bước 3: Tìm X xem có xuất hiện trong mảng không. Nếu xuất hiện chỉ ra vị trí của X. Giả sử vị trí này là: index_del
int index_del = Array.IndexOf(array, X);
if (index_del == -1)
{
    Console.WriteLine("Không tìm thấy phần tử {0} trong mảng", X);
}
else
{
    Console.WriteLine("Phần tử {0} xuất hiện ở vị trí {1}", X, index_del);

    // Bước 4: Thực hiện xoá phần tử X khỏi mảng
    for (int i = index_del; i < array.Length - 1; i++)
    {
        array[i] = array[i + 1];
    }

    // Bước 5: Kết thúc duyệt mảng. In ra mảng.
    Array.Resize(ref array, array.Length - 1);
    Console.Write("Mảng sau khi xoá phần tử {0}: ", X);
    foreach (int item in array)
    {
        Console.Write("{0} ", item);
    }
}

