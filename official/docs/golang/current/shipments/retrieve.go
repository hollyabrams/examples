package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")

	fmt.Println(shipment)
}
