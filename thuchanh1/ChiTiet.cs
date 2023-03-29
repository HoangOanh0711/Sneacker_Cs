using System;
using System.Runtime.Intrinsics.X86;
using thuchanh1.Component;

namespace thuchanh1
{
    public partial class ChiTiet : Form
    {
        public ChiTiet()
        {
            InitializeComponent();
        }

        public ChiTiet(string ten, string tien, string loai, string _tenanh)
        {
            InitializeComponent();

            ctTen = ten;
            ctTien = tien;
            ctLoai = loai;
            tenAnh = _tenanh;

            ctAnh_a = Image.FromFile("Resources/" + _tenanh + "a.jpg");
            ctAnh_b = Image.FromFile("Resources/" + _tenanh + "b.jpg");
            ctAnh_c = Image.FromFile("Resources/" + _tenanh + "c.jpg");
            ctAnh_d = Image.FromFile("Resources/" + _tenanh + "d.jpg");

            pictureBox.BackgroundImage = img_a.BackgroundImage;

            /*List<in4chitiet> in4chitiets = new List<in4chitiet>();*/

            /*int i = int.Parse(ten)-1;*/

            List<in4chitiet> in4Chitiets = new List<in4chitiet>();
            in4Chitiets.Add(new in4chitiet("1", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("2", "THIẾT KẾ BIỂU TƯỢNG", "Suốt hơn 50 năm, đôi sneaker adidas Superstar luôn là lựa chọn hàng đầu của các huyền thoại thể thao và thời trang đường phố, kết nối các nhà kiến tạo đến từ mọi nền văn hóa.", "CÁC CHI TIẾT ĐẶC TRƯNG", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "CHẤT LIỆU CAO CẤP", "Luôn hợp mốt, giày có kiểu dáng kinh điển với chất liệu da cật tăng cường độ bền chắc và thoải mái.", "THIẾT KẾ CỔ THẤP ĐẶC TRƯNG VỚI MŨI GIÀY VỎ SÒ.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White"));
            in4Chitiets.Add(new in4chitiet("3", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("4", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "ĐÔI GIÀY ADIDAS THƯỜNG NGÀY DÀNH CHO TẤT CẢ MỌI NGƯỜI.", "Giày adidas Superstar vốn dành cho sân bóng rổ nhưng chẳng mấy chốc đã hiện diện trên sân khấu, sàn diễn thời trang và hơn thế nữa. Suốt từ năm 1970, đây vẫn luôn là một trong những dòng giày trainer được ưa chuộng nhất thế giới, với mũi vỏ sò classic không ngừng chiếm trọn spotlight. Phiên bản này có 3 Sọc đục lỗ và đế cupsole bằng cao su kế thừa truyền thống ấy, là minh chứng rằng một biểu tượng không bao giờ phai nhạt mà chỉ tuyệt vời hơn theo thời gian.", "Dáng regular fit", "Có dây giày", "Thân giày bằng da tổng hợp", "Lớp lót bằng vải dệt", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Clear Pink / Pulse Magenta"));
            in4Chitiets.Add(new in4chitiet("5", "ĐÔI GIÀY CỔ THẤP CLASSIC PHIÊN BẢN MỚI VỚI HỌA TIẾT DA RẮN.", "Phiên bản sang chảnh của một thiết kế classic. Năm 1984, giày adidas Forum ra mắt trong sự đón nhận nồng nhiệt của giới bóng rổ. Phần còn lại của thế giới cũng bắt nhịp không lâu sau đó. Phiên bản này sử dụng kết hợp các chất liệu da cao cấp và điểm xuyết họa tiết da rắn cùng quai chữ X đặc trưng, lưỡi gà lót đệm và đế cupsole bằng cao su. Quai cổ chân đặc trưng đảm bảo độ ôm cũng như phong cách của bạn. Mời bạn trải nghiệm.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "ĐÔI GIÀY ADIDAS THƯỜNG NGÀY DÀNH CHO TẤT CẢ MỌI NGƯỜI.", "Có dây giày", "Thân giày bằng da nubuck, da lộn và da cật", "Lớp lót bằng vải dệt", "Đế cupsole bằng cao su", "Màu sản phẩm: Cloud White / Orbit Grey / Off White", "Mã sản phẩm: FZ6292"));
            in4Chitiets.Add(new in4chitiet("6", "THIẾT KẾ BIỂU TƯỢNG", "Suốt hơn 50 năm, đôi sneaker adidas Superstar luôn là lựa chọn hàng đầu của các huyền thoại thể thao và thời trang đường phố, kết nối các nhà kiến tạo đến từ mọi nền văn hóa.", "CÁC CHI TIẾT ĐẶC TRƯNG", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "CHẤT LIỆU CAO CẤP", "Luôn hợp mốt, giày có kiểu dáng kinh điển với chất liệu da cật tăng cường độ bền chắc và thoải mái.", "THIẾT KẾ CỔ THẤP ĐẶC TRƯNG VỚI MŨI GIÀY VỎ SÒ.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White"));
            in4Chitiets.Add(new in4chitiet("7", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "ĐÔI GIÀY ADIDAS THƯỜNG NGÀY DÀNH CHO TẤT CẢ MỌI NGƯỜI.", "ĐÔI GIÀY BÓNG RỔ CLASSIC THEO PHIÊN BẢN HEITOR.", "Điểm nhấn độc đáo cùng các chi tiết tinh tế, màu sắc trên đôi giày Forum 84 Low ADV thứ hai của Heitor da Silva đưa cá tính của anh vào một item biểu tượng. Kết hợp phong cách quần vợt của thiết kế Forum 84 Low cùng chất liệu cao cấp và vẻ đẹp xa hoa, Heitor x Forum 84 Low nổi bật lên nhờ cá tính. Được thiết kế dành cho dân trượt ván, đế giữa bằng EVA cao cấp và lót giày đúc Adiprene mang đến cảm giác vừa vặn, thoải mái và nâng đỡ, đồng thời thân giày bằng da và da lộn cao cấp, bịt mũi giày hai lớp và cấu trúc đế cupsole bền chắc mang đến vẻ ngoài sang trọng, lấy cảm hứng qua lăng kính của Heitor.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White", "Thân giày bằng da", "Đế ngoài bằng cao su"));
            in4Chitiets.Add(new in4chitiet("8", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("9", "THIẾT KẾ BIỂU TƯỢNG", "Suốt hơn 50 năm, đôi sneaker adidas Superstar luôn là lựa chọn hàng đầu của các huyền thoại thể thao và thời trang đường phố, kết nối các nhà kiến tạo đến từ mọi nền văn hóa.", "CÁC CHI TIẾT ĐẶC TRƯNG", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "CHẤT LIỆU CAO CẤP", "Luôn hợp mốt, giày có kiểu dáng kinh điển với chất liệu da cật tăng cường độ bền chắc và thoải mái.", "THIẾT KẾ CỔ THẤP ĐẶC TRƯNG VỚI MŨI GIÀY VỎ SÒ.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White"));
            in4Chitiets.Add(new in4chitiet("10", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("11", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("12", "THIẾT KẾ BIỂU TƯỢNG", "Suốt hơn 50 năm, đôi sneaker adidas Superstar luôn là lựa chọn hàng đầu của các huyền thoại thể thao và thời trang đường phố, kết nối các nhà kiến tạo đến từ mọi nền văn hóa.", "CÁC CHI TIẾT ĐẶC TRƯNG", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "CHẤT LIỆU CAO CẤP", "Luôn hợp mốt, giày có kiểu dáng kinh điển với chất liệu da cật tăng cường độ bền chắc và thoải mái.", "THIẾT KẾ CỔ THẤP ĐẶC TRƯNG VỚI MŨI GIÀY VỎ SÒ.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White"));
            in4Chitiets.Add(new in4chitiet("13", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("14", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "ĐÔI GIÀY ADIDAS THƯỜNG NGÀY DÀNH CHO TẤT CẢ MỌI NGƯỜI.", "Giày adidas Superstar vốn dành cho sân bóng rổ nhưng chẳng mấy chốc đã hiện diện trên sân khấu, sàn diễn thời trang và hơn thế nữa. Suốt từ năm 1970, đây vẫn luôn là một trong những dòng giày trainer được ưa chuộng nhất thế giới, với mũi vỏ sò classic không ngừng chiếm trọn spotlight. Phiên bản này có 3 Sọc đục lỗ và đế cupsole bằng cao su kế thừa truyền thống ấy, là minh chứng rằng một biểu tượng không bao giờ phai nhạt mà chỉ tuyệt vời hơn theo thời gian.", "Dáng regular fit", "Có dây giày", "Thân giày bằng da tổng hợp", "Lớp lót bằng vải dệt", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Clear Pink / Pulse Magenta"));
            in4Chitiets.Add(new in4chitiet("15", "ĐÔI GIÀY CỔ THẤP CLASSIC PHIÊN BẢN MỚI VỚI HỌA TIẾT DA RẮN.", "Phiên bản sang chảnh của một thiết kế classic. Năm 1984, giày adidas Forum ra mắt trong sự đón nhận nồng nhiệt của giới bóng rổ. Phần còn lại của thế giới cũng bắt nhịp không lâu sau đó. Phiên bản này sử dụng kết hợp các chất liệu da cao cấp và điểm xuyết họa tiết da rắn cùng quai chữ X đặc trưng, lưỡi gà lót đệm và đế cupsole bằng cao su. Quai cổ chân đặc trưng đảm bảo độ ôm cũng như phong cách của bạn. Mời bạn trải nghiệm.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "ĐÔI GIÀY ADIDAS THƯỜNG NGÀY DÀNH CHO TẤT CẢ MỌI NGƯỜI.", "Có dây giày", "Thân giày bằng da nubuck, da lộn và da cật", "Lớp lót bằng vải dệt", "Đế cupsole bằng cao su", "Màu sản phẩm: Cloud White / Orbit Grey / Off White", "Mã sản phẩm: FZ6292"));
            in4Chitiets.Add(new in4chitiet("16", "THIẾT KẾ BIỂU TƯỢNG", "Suốt hơn 50 năm, đôi sneaker adidas Superstar luôn là lựa chọn hàng đầu của các huyền thoại thể thao và thời trang đường phố, kết nối các nhà kiến tạo đến từ mọi nền văn hóa.", "CÁC CHI TIẾT ĐẶC TRƯNG", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "CHẤT LIỆU CAO CẤP", "Luôn hợp mốt, giày có kiểu dáng kinh điển với chất liệu da cật tăng cường độ bền chắc và thoải mái.", "THIẾT KẾ CỔ THẤP ĐẶC TRƯNG VỚI MŨI GIÀY VỎ SÒ.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White"));
            in4Chitiets.Add(new in4chitiet("17", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "ĐÔI GIÀY ADIDAS THƯỜNG NGÀY DÀNH CHO TẤT CẢ MỌI NGƯỜI.", "ĐÔI GIÀY BÓNG RỔ CLASSIC THEO PHIÊN BẢN HEITOR.", "Điểm nhấn độc đáo cùng các chi tiết tinh tế, màu sắc trên đôi giày Forum 84 Low ADV thứ hai của Heitor da Silva đưa cá tính của anh vào một item biểu tượng. Kết hợp phong cách quần vợt của thiết kế Forum 84 Low cùng chất liệu cao cấp và vẻ đẹp xa hoa, Heitor x Forum 84 Low nổi bật lên nhờ cá tính. Được thiết kế dành cho dân trượt ván, đế giữa bằng EVA cao cấp và lót giày đúc Adiprene mang đến cảm giác vừa vặn, thoải mái và nâng đỡ, đồng thời thân giày bằng da và da lộn cao cấp, bịt mũi giày hai lớp và cấu trúc đế cupsole bền chắc mang đến vẻ ngoài sang trọng, lấy cảm hứng qua lăng kính của Heitor.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White", "Thân giày bằng da", "Đế ngoài bằng cao su"));
            in4Chitiets.Add(new in4chitiet("18", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));
            in4Chitiets.Add(new in4chitiet("19", "THIẾT KẾ BIỂU TƯỢNG", "Suốt hơn 50 năm, đôi sneaker adidas Superstar luôn là lựa chọn hàng đầu của các huyền thoại thể thao và thời trang đường phố, kết nối các nhà kiến tạo đến từ mọi nền văn hóa.", "CÁC CHI TIẾT ĐẶC TRƯNG", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "Mũi giày vỏ sò dễ dàng nhận diện ngay lập tức kết hợp với ba sọc viền răng cưa và các điểm nhấn adidas Originals.", "CHẤT LIỆU CAO CẤP", "Luôn hợp mốt, giày có kiểu dáng kinh điển với chất liệu da cật tăng cường độ bền chắc và thoải mái.", "THIẾT KẾ CỔ THẤP ĐẶC TRƯNG VỚI MŨI GIÀY VỎ SÒ.", "Thân giày bằng da", "Biểu tượng giày da", "Đế ngoài bằng cao su", "Màu sản phẩm: Cloud White / Core Black / Cloud White"));
            in4Chitiets.Add(new in4chitiet("20", "PHONG CÁCH NHỮNG NĂM 2000", "Quay trở lại thập niên thời trang nổi loạn.", "LỚP ĐỆM SIÊU NHẸ", "Đế giữa EVA hấp thụ lực tác động cho cảm giác bền chắc mà thoải mái.", "QUAI SAU CÓ THỂ THÁO RỜI", "Quai dép có thể nới lỏng, kéo chặt hoặc tháo rời.", "PHIÊN BẢN DÉP SANDAL CỦA ĐÔI GIÀY ASTIR RẤT ĐƯỢC YÊU THÍCH.", "Nếu bạn có sở thích cắm trại thời những năm 2000 thì đôi dép dưới chân bạn có lẽ trông hơi giống đôi này. Vô cùng thoải mái và đậm chất Y2K, đôi dép sandal adidas Astir này kết hợp các đường nét uyển chuyển với hệ thống dây buộc thông minh và lớp đệm êm ái. Bạn có thể phối đôi dép này với mọi outfit. Tận hưởng từng sải bước dễ chịu nhờ lòng dép bằng mút nhớ hình siêu mềm mại.", "Quai dán có thể tháo rời", "Thân dép bằng da lộn và da tổng hợp", "Lớp lót bằng vải dệt", "Lòng dép bằng mút nhớ hình"));

            int i = int.Parse(_tenanh) - 1;

            flowLayoutPanel1.Controls.Add(in4Chitiets[i]);

        }

        /*
                public void AddItem(string tenanh, string lbnb1, string txnb1, string lbnb2, string txnb2, string lbnb3, string txnb3, string lbmt1, string txmt1, string txct1, string txct2, string txct3, string txct4, string txct5, string txct6)
                {
                    flowLayoutPanel1.Controls.Add(new in4chitiet()
                    {
                        in4_lbnb1 = lbnb1,
                        in4_txnb1 = txnb1,
                        in4_imgnb1 = Image.FromFile("Resources/" + tenanh + "a.jpg"),

                        in4_lbnb2 = lbnb2,
                        in4_txnb2 = txnb2,
                        in4_imgnb2 = Image.FromFile("Resources/" + tenanh + "b.jpg"),

                        in4_lbnb3 = lbnb3,
                        in4_txnb3 = txnb3,
                        in4_imgnb3 = Image.FromFile("Resources/" + tenanh + "c.jpg"),

                        in4_lbmt1 = lbmt1,
                        in4_txmt1 = txmt1,
                        in4_imgmt1 = Image.FromFile("Resources/" + tenanh + "d.jpg"),

                        in4_txct1 = txct1,
                        in4_txct2 = txct2,
                        in4_txct3 = txct3,
                        in4_txct4 = txct4,
                        in4_txct5 = txct5,
                        in4_txct6 = txct6,
                    });
                }
        */

        private string tenanh;
        public string tenAnh { get => tenanh; set => tenanh = value; }
        public string ctTien { get => lb_giatien.Text; set => lb_giatien.Text = value; }
        public string ctTen { get => lb_ten.Text; set => lb_ten.Text = value; }
        public string ctLoai { get => lb_loai.Text; set => lb_loai.Text = value; }

        public Image ctAnh_a { get => img_a.BackgroundImage; set => img_a.BackgroundImage = value; }
        public Image ctAnh_b { get => img_b.BackgroundImage; set => img_b.BackgroundImage = value; }
        public Image ctAnh_c { get => img_c.BackgroundImage; set => img_c.BackgroundImage = value; }
        public Image ctAnh_d { get => img_d.BackgroundImage; set => img_d.BackgroundImage = value; }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newForm = new LichSuMuaHang();
            newForm.Show();
        }

        private void ChiTiet_Shown(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img_a_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = img_a.BackgroundImage;
        }

        private void img_b_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = img_b.BackgroundImage;
        }

        private void img_c_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = img_c.BackgroundImage;
        }

        private void img_d_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = img_d.BackgroundImage;
        }
    }
}