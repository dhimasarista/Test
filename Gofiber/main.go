package main

import (
	"github.com/gofiber/fiber/v2"
)

type Data struct {
	ID     int    `json:"id"`
	Nama   string `json:"nama"`
	Alamat string `json:"alamat"`
	Kota   string `json:"kota"`
}

func index(c *fiber.Ctx) error {
	data := []Data{
		{ID: 1, Nama: "John Doe", Alamat: "Jalan ABC", Kota: "Jakarta"},
		{ID: 2, Nama: "Jane Doe", Alamat: "Jalan DEF", Kota: "Bandung"},
		{ID: 3, Nama: "Bob Smith", Alamat: "Jalan GHI", Kota: "Surabaya"},
	}

	// Using fiber's JSON method to respond with the data as JSON
	return c.JSON(fiber.Map{
		"data": data,
	})
}

func main() {
	// Create a new fiber app
	app := fiber.New()

	// Set up a route
	app.Get("/", index)

	// Start the server on port 9000
	app.Listen(":8000")
}
