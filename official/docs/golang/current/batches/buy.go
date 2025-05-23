package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func buy() {
	client := easypost.New("EASYPOST_API_KEY")

	createdBatch, _ := client.CreateBatch(
		&easypost.Shipment{
			FromAddress: &easypost.Address{
				ID: "adr_...",
			},
			ToAddress: &easypost.Address{
				ID: "adr_...",
			},
			Parcel: &easypost.Parcel{
				ID: "prcl_...",
			},
			Service:           "First",
			Carrier:           "USPS",
			CarrierAccountIDs: []string{"ca_..."},
		},
	)

	batch, _ := client.BuyBatch(createdBatch.ID)

	fmt.Println(batch)
}
