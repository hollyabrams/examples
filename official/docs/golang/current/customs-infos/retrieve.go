package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	customsInfo, _ := client.GetCustomsInfo("cstinfo_...")

	fmt.Println(customsInfo)
}
