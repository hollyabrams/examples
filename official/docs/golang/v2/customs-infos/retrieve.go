package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	customsInfo, _ := client.GetCustomsInfo("cstinfo_...")

	fmt.Println(customsInfo)
}
