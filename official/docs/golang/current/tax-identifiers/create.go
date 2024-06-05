package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")
	parcel, _ := client.GetParcel("prcl_...")

	shipment, _ := client.CreateShipment(
		&easypost.Shipment{
			ToAddress:   toAddress,
			FromAddress: fromAddress,
			Parcel:      parcel,
			TaxIdentifiers: []*easypost.TaxIdentifier{
				&easypost.TaxIdentifier{
					Entity:         "SENDER",
					TaxId:          "GB123456789",
					IssuingCountry: "GB",
					TaxIdType:      "EORI",
				},
			},
		},
	)

	fmt.Println(shipment)
}
