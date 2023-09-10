program struktur_Case;
var
   nilai: char;
begin
   read (nilai);

   case (nilai) of
      'A' : write ('Luar biasa!' );
      'B' : write ('Bagus' );
      'C' : write ('Cukup' );
      'D' : write ('Kurang' );
      'F' : write ('Coba Lagi' );
    else
      write ('Grade (nilai) salah');
   end;     
end.