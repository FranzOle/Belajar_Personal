//
 

 
// Here is a small helper for you! Have a look.
#include "ResourcePath.hpp"
 
#include "Bat.hpp"
#include "Ball.hpp"
 
#include
#include
#include 
 
using namespace sf;
 
int main(int, char const**)
{
    int windowWidth = 800;
    int windowHeight = 600;
 
    // Membuat main window
    RenderWindow window(VideoMode(windowWidth, windowHeight), "pong");
 
    int score = 0;
    int lives = 3;
 
    // Membuat bet pada posisi tengah bawah
    Bat bat(windowWidth / 2, windowHeight - 20);
    // Membuat ball pada posisi awal tengah atas
    Ball ball(windowWidth / 2, 1);
 
    // Mengatur Icon
    Image icon;
    if (!icon.loadFromFile(resourcePath() + "icon.png")) {
        return EXIT_FAILURE;
    }
    window.setIcon(icon.getSize().x, icon.getSize().y, icon.getPixelsPtr());
 
    // Load font
    Font font;
    if (!font.loadFromFile(resourcePath() + "sansation.ttf")) {
        return EXIT_FAILURE;
    }
 
    // Membuat teks untuk menampilkan score dan live
    Text hud;
    hud.setFont(font);
    hud.setCharacterSize(50);
    hud.setFillColor(Color::White);
 
    // Memulai pengulangan game
    while (window.isOpen())
    {
        // Process events
        Event event;
        while (window.pollEvent(event))
        {
            // Menutup window
            if (event.type == Event::Closed)
            {
                window.close();
            }
 
            // Tekan Escape: untuk keluar
            if (event.type == Event::KeyPressed &amp;&amp; event.key.code == Keyboard::Escape)
            {
                window.close();
            }
        }
 
        if (Keyboard::isKeyPressed(Keyboard::Left))
        {
            // gerakan bet ke kiri...
            bat.moveLeft();
        }
        else if (Keyboard::isKeyPressed(Keyboard::Right))
        {
            // gerakan bet ke kanan...
            bat.moveRight();
        }
 
        // update layar
        // jika bola meyentuh lantai bawah
        if (ball.getPosition().top &gt; windowHeight)
        {
            // mengulangi dari posisi awal
            ball.hitBottom();
            // kurangi nyawa
            lives--;
 
            // cek nyawa jika habis
            if (lives &lt; 1)
            {
                // reset score
                score = 0;
                // reset lives
                lives = 3;
            }
        }
 
        // jika bola menentuh atas
        if (ball.getPosition().top &lt; 0)
        {
            ball.reboundBatOrtop();
            // menambah satu poin pada skor
            score++;
        }
 
        // jika bola menyentuh dinding
        if (ball.getPosition().left  windowWidth)
        {
            ball.reboundSides();
        }
 
        // jika bola menyentuh bet
        if (ball.getPosition().intersects(bat.getPosition()))
        {
            // bola memantul ke arah berlawanan
            ball.reboundBatOrtop();
        }
 
        ball.update();
        bat.update();
 
//        std::cout &lt;&lt; &quot;ball.pos.x = &quot; &lt;&lt; ball.getPosition().left &lt;&lt; std::endl;
//        std::cout &lt;&lt; &quot;ball.pos.y = &quot; &lt;&lt; ball.getPosition().top &lt;&lt; std::endl;
 
        // Update tulisan skor dan nyawa
        std::stringstream ss;
        ss &lt;&lt; &quot;Score: &quot; &lt;&lt; score &lt;&lt; &quot;   Lives: &quot; &lt;<span id="mce_SELREST_start" style="overflow:hidden;line-height:0;"></span>&lt; lives;
        hud.setString(ss.str());
 
        // bersihkan layar
        window.clear(Color(26, 128, 182,255));
 
        // updete gambar bet dan bola
        window.draw(bat.getShape());
        window.draw(ball.getShape());
 
        // update teks
        window.draw(hud);
 
        // Update window
        window.display();
    }
 
    return EXIT_SUCCESS;
}
