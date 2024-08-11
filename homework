import java.util.*;

class Notebook {
    private String model;
    private int ram; // ОЗУ в ГБ
    private int storage; // Объем ЖД в ГБ
    private String operatingSystem;
    private String color;

    public Notebook(String model, int ram, int storage, String operatingSystem, String color) {
        this.model = model;
        this.ram = ram;
        this.storage = storage;
        this.operatingSystem = operatingSystem;
        this.color = color;
    }

    public int getRam() {
        return ram;
    }

    public int getStorage() {
        return storage;
    }

    public String getOperatingSystem() {
        return operatingSystem;
    }

    public String getColor() {
        return color;
    }

    public String toString() {
        return "Notebook{" +
                "model='" + model + '\'' +
                ", ram=" + ram +
                ", storage=" + storage +
                ", operatingSystem='" + operatingSystem + '\'' +
                ", color='" + color + '\'' +
                '}';
    }
}

public class NotebookStore {
    private List<Notebook> notebooks;

    public NotebookStore() {
        notebooks = new ArrayList<>();
        // Добавление тестовых ноутбуков
        notebooks.add(new Notebook("Model A", 8, 256, "Windows", "Black"));
        notebooks.add(new Notebook("Model B", 16, 512, "Linux", "Silver"));
        notebooks.add(new Notebook("Model C", 4, 128, "Windows", "White"));
        notebooks.add(new Notebook("Model D", 32, 1024, "MacOS", "Gray"));
    }

    public void filterNotebooks() {
        Scanner scanner = new Scanner(System.in);
        Map<Integer, Integer> filters = new HashMap<>();

        System.out.println("Введите цифру, соответствующую необходимому критерию:");
        System.out.println("1 - ОЗУ (ГБ)");
        System.out.println("2 - Объем ЖД (ГБ)");
        System.out.println("3 - Операционная система");
        System.out.println("4 - Цвет");

        while (true) {
            int criterion = scanner.nextInt();
            if (criterion < 1 || criterion > 4) {
                break;
            }
            System.out.print("Введите минимальное значение: ");
            int minValue = scanner.nextInt();
            filters.put(criterion, minValue);
        }

        List<Notebook> filteredNotebooks = new ArrayList<>(notebooks);
        
        for (Map.Entry<Integer, Integer> entry : filters.entrySet()) {
            switch (entry.getKey()) {
                case 1: // ОЗУ
                    filteredNotebooks.removeIf(notebook -> notebook.getRam() < entry.getValue());
                    break;
                case 2: // Объем ЖД
                    filteredNotebooks.removeIf(notebook -> notebook.getStorage() < entry.getValue());
                    break;
                case 3: // Операционная система
                    System.out.print("Введите операционную систему: ");
                    String os = scanner.next();
                    filteredNotebooks.removeIf(notebook -> !notebook.getOperatingSystem().equalsIgnoreCase(os));
                    break;
                case 4: // Цвет
                    System.out.print("Введите цвет: ");
                    String color = scanner.next();
                    filteredNotebooks.removeIf(notebook -> !notebook.getColor().equalsIgnoreCase(color));
                    break;
            }
        }

        System.out.println("Найденные ноутбуки:");
        for (Notebook notebook : filteredNotebooks) {
            System.out.println(notebook);
        }
    }

    public static void main(String[] args) {
        NotebookStore store = new NotebookStore();
        store.filterNotebooks();
    }
}
