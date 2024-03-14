package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	carrierAccount, _ := client.GetCarrierAccount("ca_...")

	fmt.Println(carrierAccount)
}
