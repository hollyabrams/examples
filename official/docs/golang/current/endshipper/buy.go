package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	rate, _ := client.LowestShipmentRate(shipment)

	shipment, _ = client.BuyShipmentWithEndShipper(shipment.ID, &rate, "0", "es_...")

	fmt.Println(shipment)
}
