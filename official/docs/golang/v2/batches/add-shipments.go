package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, _ := client.GetShipment("shp_...")

	batch, _ := client.AddShipmentsToBatch("batch_...", shipment)

	fmt.Println(batch)
}
